using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProcessamentoImagens
{
    class Filtros
    {
        //sem acesso direto a memoria
        public static void convert_to_gray(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;
            Int32 gs;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;
                    gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);

                    //nova cor
                    Color newcolor = Color.FromArgb(gs, gs, gs);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //sem acesso direito a memoria
        public static void negativo(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int r, g, b;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //obtendo a cor do pixel
                    Color cor = imageBitmapSrc.GetPixel(x, y);

                    r = cor.R;
                    g = cor.G;
                    b = cor.B;

                    //nova cor
                    Color newcolor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                    imageBitmapDest.SetPixel(x, y, newcolor);
                }
            }
        }

        //com acesso direto a memória
        public static void convert_to_grayDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            //lock dados bitmap origem
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++); //está armazenado dessa forma: b g r 
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        //com acesso direito a memoria
        public static void negativoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            //lock dados bitmap origem 
            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            //lock dados bitmap destino
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src1 = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src1++); //está armazenado dessa forma: b g r 
                        g = *(src1++);
                        r = *(src1++);

                        *(dst++) = (byte)(255 - b);
                        *(dst++) = (byte)(255 - g);
                        *(dst++) = (byte)(255 - r);
                    }
                    src1 += padding;
                    dst += padding;
                }
            }
            //unlock imagem origem 
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            //unlock imagem destino
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        public static void afinamentoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapDest.Height;
            int pixelSize = 3;

            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();
                bool encontrou = false; //flag pra caso seja encontrado
                bool flagAux = false; //flag para controlar as iterações


                for (int y = 0; y < height; y++)
                {
                    byte* src2 = src;
                    byte* dst2 = dst;
                    for (int x = 0; x < width; x++)
                    {
                        // Ordem do pixel é Azul, Verde, Vermelho (NÃO é vermelho, verde, azul)
                        if (!pixelBranco(src2)) // se não for branco, pinta de preto
                        {
                            dst2[0] = 0;
                            dst2[1] = 0;
                            dst2[2] = 0;
                        }
                        else //define como branco
                        {
                            dst2[0] = 255;
                            dst2[1] = 255;
                            dst2[2] = 255;
                        }
                        src2 = src2 + pixelSize;
                        dst2 = dst2 + pixelSize;
                    }
                    src = src + bitmapDataSrc.Stride;
                    dst = dst + bitmapDataDst.Stride;
                }

                while (!encontrou)
                {
                    dst = (byte*)bitmapDataDst.Scan0.ToPointer();
                    List<IntPtr> ListaPixels = new List<IntPtr>();

                    for (int y = 0; y < height; y++)
                    {
                        byte* dst2 = dst;

                        for (int x = 0; x < width; x++)
                        {
                            if ((y > 0 && y < height - 1) && (x > 0 && x < width - 1) && !pixelBranco(dst2))
                            {
                                int conectividade = Conectividade(dst2, bitmapDataSrc.Stride);
                                if (conectividade == 1)
                                {
                                    int proxPixelPreto = contaPixels(dst2, bitmapDataSrc.Stride);

                                    if (proxPixelPreto >= 2 && proxPixelPreto <= 6)
                                    {
                                        byte* linhaCima = dst2 - bitmapDataSrc.Stride;
                                        byte* linhaBaixo = dst2 + bitmapDataSrc.Stride;

                                        bool cond1 = pixelBranco(linhaCima) || pixelBranco(linhaBaixo) || pixelBranco(dst2 - 3);
                                        bool cond2 = pixelBranco(linhaCima + 3) || pixelBranco(dst2 + 3) || pixelBranco(linhaBaixo + 3);
                                        bool cond3 = pixelBranco(linhaCima) || pixelBranco(dst2 + 3) || pixelBranco(linhaCima + 3);
                                        bool cond4 = pixelBranco(linhaBaixo) || pixelBranco(dst2 - 3) || pixelBranco(linhaBaixo + 3);

                                        if ((flagAux && cond2 && cond4) || (!flagAux && cond1 && cond3))
                                            ListaPixels.Add((IntPtr) dst2);                                    }
                                }
                            }

                            dst2 = dst2 + pixelSize;
                        }

                        dst = dst2 + bitmapDataSrc.Stride;
                    }
                    encontrou = flagAux && ListaPixels.Count == 0;

                    flagAux = !flagAux;

                    foreach (byte* p in ListaPixels)
                    {
                        p[0] = 255;
                        p[1] = 255;
                        p[2] = 255;
                    }
                    ListaPixels.Clear();
                }
            }

            // Unlock imagem origem e destino
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }

        private static unsafe bool pixelBranco(byte* rowDst)
        {
            int p = 200;
            if (rowDst[0] >= p && rowDst[1] >= p && rowDst[2] >= p)
                return true;
            return false;
        }
        private static unsafe bool pixelPreto(byte* rowDst)
        {
            return (rowDst[0] == 0 && rowDst[1] == 0 && rowDst[2] == 0);
        }
        private static unsafe int Conectividade(byte* dst2, int stride)
        {

            byte* linhaCima = dst2 - stride;
            byte* linhaBaixo = dst2 + stride;

            int con = 0;

            con += (!pixelBranco(linhaCima + 3) && pixelBranco(linhaCima)) ? 1 : 0;
            con += (pixelBranco(linhaCima + 3) && !pixelBranco(dst2 + 3)) ? 1 : 0;
            con += (pixelBranco(linhaBaixo + 3) && !pixelBranco(linhaBaixo)) ? 1 : 0;
            con += (pixelBranco(linhaBaixo) && !pixelBranco(linhaBaixo - 3)) ? 1 : 0;
            con += (pixelBranco(linhaBaixo - 3) && !pixelBranco(dst2 - 3)) ? 1 : 0;
            con += (pixelBranco(dst2 + 3) && !pixelBranco(linhaBaixo + 3)) ? 1 : 0;
            con += (pixelBranco(dst2 - 3) && !pixelBranco(linhaCima - 3)) ? 1 : 0;
            con += (pixelBranco(linhaCima - 3) && !pixelBranco(linhaCima)) ? 1 : 0;

            return con;
        }

        private static unsafe int contaPixels(byte* rowSrc, int passo)
        {
            int qtdtotal = 0;


            byte* p1 = rowSrc - passo;
            byte* p2 = rowSrc - passo + 3;
            byte* p3 = rowSrc + 3;
            byte* p4 = rowSrc + passo + 3;
            byte* p5 = rowSrc + passo;
            byte* p6 = rowSrc + passo - 3;
            byte* p7 = rowSrc - 3;
            byte* p8 = rowSrc - passo - 3;


            qtdtotal += (!pixelBranco(p1)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p2)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p3)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p4)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p5)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p6)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p7)) ? 1 : 0;
            qtdtotal += (!pixelBranco(p8)) ? 1 : 0;

            return qtdtotal;
        }
    }
}
