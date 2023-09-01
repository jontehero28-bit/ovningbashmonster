using BashMonster;

Gubbe gunnar = new();
Gubbe leif = new();

gunnar.hp = 100;
gunnar.dmg = 15;
gunnar.critdmg = 10;

leif.hp = 60;
leif.dmg = 10;
leif.critdmg = 30;

Console.WriteLine("Gunnar hittade en oöpnad burk av norrlands guld i soptunnan!");
Console.WriteLine("Men ånej! Leif vill ha den också!");
Console.WriteLine("Låt oss se vem vinner burken av norrlands guld!");
Console.WriteLine("Gunnar har 100hp och Leif har 60hp \nGunnar har dmg 15 och critdmg 10, Leif har dmg 10 och critdmg 30");
Console.Beep();

//--------------------------

while (gunnar.hp > 0 && leif.hp > 0)
{
    Console.WriteLine("Nu kör vi förfan!");

}

Console.ReadLine();
