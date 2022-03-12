using System;

namespace Praktikum_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //KodeBuah kode = new KodeBuah();
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Semangka));

            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.karakter();
        }

        class PosisiKarakterGame
        {
            enum State { Berdiri, Jongkok, Tengkurap, Terbang, Selesai };
            public void karakter()
            {
                State state = State.Berdiri;

                String[] screenName = { "berdiri", "jongkok", "tengkurep", "terbang" };
                do
                {
                    Console.WriteLine("\nKarakter " + screenName[(int)state] + " \n");
                    Console.Write("Masukkan tombol : ");
                    String command = Console.ReadLine();
                    switch (state)
                    {
                        case State.Berdiri:
                            if (command == "W")
                            {
                                state = State.Terbang;
                            }
                            else if (command == "S")
                            {
                                state = State.Jongkok;
                            }
                            else if (command == "Selesai")
                            {
                                state = State.Selesai;
                            }

                            break;
                        case State.Jongkok:
                            if (command == "W")
                            {
                                state = State.Berdiri;
                                Console.Write("\nposisi standby");
                            }
                            else if (command == "S")
                            {
                                state = State.Tengkurap;
                                Console.Write("\nposisi istirahat");
                            }
                            else if (command == "Selesai")
                            {
                                state = State.Selesai;
                            }

                            break;
                        case State.Tengkurap:
                            if (command == "W")
                            {
                                state = State.Jongkok;
                            }
                            else if (command == "Selesai")
                            {
                                state = State.Selesai;
                            }

                            break;
                        case State.Terbang:
                            if (command == "S")
                            {
                                state = State.Berdiri;
                                Console.Write("\nposisi standby");
                            }
                            else if (command == "X")
                            {
                                state = State.Jongkok;
                            }
                            else if (command == "Selesai")
                            {
                                state = State.Selesai;
                            }

                            break;
                                            }
                } while (state != State.Selesai);
            }

        }
    }
}
