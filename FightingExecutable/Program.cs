using Fighting.FightHandlers;
using Fighting.Heralds;
using Fighting.Heroes;
using Fighting.Heroes.Abstract;
using Fighting.Shields.Concrete;
using Fighting.Weapons;
using Fighting.Weapons.Improvements;


var plainAx = new Ax(4, "Ax of Red Warrior");
var sharpenAx = new Sharpen(plainAx);
var refinedAndSharpenAx = new Refined(sharpenAx);
CompetitiveHero hero = new Human("John", 100);
hero.Weapon = refinedAndSharpenAx;

CompetitiveHero elf = new Elf("Lorael", 120);
elf.Shield = new MagicShield("The magic shield of Lotric", 5);

CommonFightHandler.Fight(hero, elf);