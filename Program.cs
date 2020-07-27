using System;

namespace deneme_4_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // operators + ve -
            int i=50+40;
            float f=12.55f+12.45f;
            // * ve / oper.
            int b=i/20;
            float f1=f/60;
            float c=i*f;
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(f);
            Console.WriteLine(f1);
            Console.WriteLine(c);

            // % operatörü  c=40%3 -> c=1 bu operator 
            float f2=10%3;
            Console.WriteLine(f2);
            
            // ++ ve -- oper.
            int a=10;
            int x=20;
            int c1=30;
            int d=40;
            float flt=5.54f;
             //a++;
             //++x;
             c1--;
             --d;
             flt++;
             Console.WriteLine(a++);
             Console.WriteLine(++x);
             Console.WriteLine(c1);
             Console.WriteLine(d);
             Console.WriteLine(flt);
             Console.WriteLine(a);

             int a1=10;
             int a2;
             int a3;
             a2=a1++;
             a3=++a1;
             Console.WriteLine("a1 = n{0}deneme n{1}  n{2}  n{3}",a1,a2,a3,flt);
             Console.WriteLine("\"{0}\"\n{1}\n{2}\n{3}",a1,a2,a3,flt);
             Console.WriteLine($"a1 = {a1},\n{a2},\t{a3},{flt}");
             Console.WriteLine("a2 = {0} ",a2);
             Console.WriteLine($"a1 = {a1} \na2 = {a2} \na3 = {a3} \nflt = {flt}");
             Console.WriteLine($"a3 = {a3} ");

             // > ve < karşılaştırma ope.
              bool x1 =50<60;
              bool x2 =60<50;
              bool x3 =20.25>22.25;
              bool x4 = 25.25>24.24;

              Console.WriteLine("x1= \"{0}\"  \nx2= {1} \nx3= {2} \nx4= {3}",x1,x2,x3,x4);
              bool be1 = 50<=50;
              bool be2 = 50<=51;
              bool be3 = 50>=45;
              bool be4 = 50>=51;
              Console.WriteLine("be1= \"{0}\"  \nbe2= {1} \nbe3= {2} \nbe4= {3}",be1,be2,be3,be4);

              // == ve != opr.
               bool es1=50==50;
               bool es2=50!=50;
               Console.WriteLine("es1= \"{0}\"  \nes2= {1} ",es1,es2);

               // is ve as
                object oas="50";
                string sas=oas as string;
                Console.WriteLine(sas);

                int is1=50;
                bool bis=is1 is int;
                bool bis1=is1 is double;
                bool bis2=is1 is object;
                Console.WriteLine(bis);
                Console.WriteLine(bis1);
                Console.WriteLine(bis2);

                  int che1=254;
                    int che2=300;
                    byte ch1,ch2;
                      checked
                        {
                         ch1 = (byte)che1;
                            unchecked
                               {
                                    ch2=(byte)che2;
                                }
                          
                       }
                    Console.WriteLine(ch1);
                    Console.WriteLine(ch2);
                double degisken1 = 3.14123456789123456789123456789123456789;
float degisken2;

//degisken2=(float)degisken1;
degisken2 = Convert.ToSingle(degisken1);

Console.WriteLine(degisken1);
Console.WriteLine(degisken2);

// Mantıksal Operatörler && (ve) Operatörleri
bool ve1 = 35<10 && 10==50 ; 
bool ve2 = 35>10 && 10!=50 ;
bool ve3 = 14.6f>10f && 0!=100 ;
Console.WriteLine("ve1 : {0} \nve2 : {1} \nve3 : {2} ",ve1,ve2,ve3);

// || (mantıksal veya) operatörü
bool veya1 = 35<10 || 10==50 ; 
bool veya2 = 35>10 || 50!=50 ;
bool veya3 = 14.6f>10f || 0!=100 ;
bool veya4 = 10<5 || 10==10;
Console.WriteLine("veya1 : {0} \nveya2 : {1} \nveya3 : {2} \nveya4 : {3}",veya1,veya2,veya3,veya4);

 // ! (mantıksal değil operatörü (NOT))
 bool not1 = !(35<40);
 bool not2 = !(10==20);
 Console.WriteLine(not1);
 Console.WriteLine(not2);
 // Bitsel Operatörler
 // ~ (bitsel değil operatörü) "tilde"
 byte bit1 = 10;
 byte bit2 = (byte)~bit1;
 Console.WriteLine(bit2);

  // & bitsel Ve operatörü
  byte bve1 = 145;
  byte bve2 = 0;
  byte bve3 = (byte)(bve1 & bve2);
  Console.WriteLine("bve3 = {0}",bve3);

  // | bitsel veya operatörü
  byte vey1 = 145;
  byte vey2 = 73;
  int vy1 = (byte)(vey1 | vey2);
  Console.WriteLine("vy1 = {0}",vy1);

  byte  vvy1=0xB2;
  byte  vvy2=(byte)(vvy1 & 0xEC | 0X1);
  Console.WriteLine("ve veya= {0}",vvy2);
  
  // ^ (Bitsel Özel Veya) Oper.
  byte ovy1 = 10;
  byte ovy2 = 99;

  Console.WriteLine("ilk değer-> {0}",ovy2);

  ovy2 =(byte)(ovy2^ovy1);
  Console.WriteLine("ilk XOR-> {0} ",ovy2);

  ovy2 = (byte)(ovy2^ovy1);
  Console.WriteLine("ikinci XOR ->{0} ",ovy2);

  //(BİTSEL KAYDIRMA İŞLEMİ ) << 
  byte kay = 10;
  byte kay1 = (byte)(kay<<1);
  byte kay2 = (byte)(kay>>1);
  Console.WriteLine($"kay= {kay} \nkay1= {kay1} \nkay2= {kay2}");
  
  // ?: (ternary operatörü)
  int sayi;
  Console.Write("Kalem sayısını girin : ");
  sayi=Convert.ToInt32(Console.ReadLine());
  //sayi=Console.ReadLine(); yanlış yazım
  string str ="kalem";
  str = str+(sayi==1 ? " " : "ler");
  Console.WriteLine(str);

  // () tür dönüşüm operatörü
  byte tur =10;
  int tur1 = (int)tur;
    uint ısa1=50;
    int ısa2=(int)-ısa1;
    Console.WriteLine(tur1);
    Console.WriteLine(ısa2);
    

    int nw = new int();
    byte nw1 = new byte();
    double nw3 = new double();
    Console.WriteLine(nw);
    Console.WriteLine(nw1);
    Console.WriteLine(nw3);

    /*Type t1 = typeof(Operatorler15);
    Operatorler15 den = new Operatorler15();
    Type t2 = den.GetType();
    Console.WriteLine(t1.ToString());
    Console.WriteLine(t2.ToString());*/
    







    











     






                



            








        }
    }
}
