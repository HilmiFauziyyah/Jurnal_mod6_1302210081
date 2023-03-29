using MOD6_1302210081;

string username = " Review Film Dari Hilmi Fauziyyah ";
string judul1 = " Dear Nathan";
string judul2 = " KKN Di Desa Penari";
string judul3 = " DOTS";
string judul4 = " Spongebob";
string judul5 = " Kuntilanak";
string judul6 = " IT";
string judul7 = " Menjelang Maghrib";
string judul8 = " Insyallah SAH";
string judul9 = " Bayi Ajaib";
string judul10 = " Pengabdi Setan";


SayaTubeUser su = new SayaTubeUser(username);
SayaTubeVideo sa1 = new SayaTubeVideo(judul1);
SayaTubeVideo sa2 = new SayaTubeVideo(judul2);
SayaTubeVideo sa3 = new SayaTubeVideo(judul3);
SayaTubeVideo sa4 = new SayaTubeVideo(judul4);
SayaTubeVideo sa5 = new SayaTubeVideo(judul5);
SayaTubeVideo sa6 = new SayaTubeVideo(judul6);
SayaTubeVideo sa7 = new SayaTubeVideo(judul7);
SayaTubeVideo sa8 = new SayaTubeVideo(judul8);
SayaTubeVideo sa9 = new SayaTubeVideo(judul9);
SayaTubeVideo sa10 = new SayaTubeVideo(judul10);

su.PrintAllVideoCount();
sa1.PrintVideoDetail();
Console.WriteLine("");
sa2.PrintVideoDetail();
Console.WriteLine("");
sa3.PrintVideoDetail();
Console.WriteLine("");
sa4.PrintVideoDetail();
Console.WriteLine("");
sa5.PrintVideoDetail();
Console.WriteLine("");
sa6.PrintVideoDetail();
Console.WriteLine("");
sa7.PrintVideoDetail();
Console.WriteLine("");
sa8.PrintVideoDetail();
Console.WriteLine("");
sa9.PrintVideoDetail();
Console.WriteLine("");
sa10.PrintVideoDetail();
Console.WriteLine("");


