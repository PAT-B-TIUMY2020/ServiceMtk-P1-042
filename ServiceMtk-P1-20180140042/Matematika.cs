﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140042
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                //Secara default
                //throw new Exception(ex.message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah !";
                mf.Pesan = "Masukkan inputan yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //Secara default
                //throw new Exception(ex.message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah !";
                mf.Pesan = "Masukkan inputan yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //Secara default
                //throw new Exception(ex.message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah !";
                mf.Pesan = "Masukkan inputan yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //Secara default
                //throw new Exception(ex.message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah !";
                mf.Pesan = "Masukkan inputan yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //Secara default
                //throw new Exception(ex.message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah !";
                mf.Pesan = "Masukkan inputan yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
