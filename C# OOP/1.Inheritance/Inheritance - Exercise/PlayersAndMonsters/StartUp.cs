using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Hero",1);
            Console.WriteLine(hero.ToString());

            Elf elf = new Elf("Elf", 2);
            Console.WriteLine(elf.ToString());

            MuseElf museElf = new MuseElf("MuseElf", 3);
            Console.WriteLine(museElf.ToString());

            Wizard wizard = new Wizard("Wizard", 4);
            Console.WriteLine(wizard.ToString());

            DarkWizard darkWizard = new DarkWizard("DarkiWizard",5);
            Console.WriteLine(darkWizard.ToString());

            SoulMaster soulMaster = new SoulMaster("SoulMastes", 6);
            Console.WriteLine(soulMaster.ToString());

            Knight knight = new Knight("Knight", 7);
            Console.WriteLine(knight.ToString());

            DarkKnight darkiKnight = new DarkKnight("DarkKnight", 8);
            Console.WriteLine(darkiKnight.ToString());

            BladeKnight bladeKnight = new BladeKnight("BladeKnight", 9);
            Console.WriteLine(bladeKnight.ToString());
        }
    }
}