using Fighting.FightHandlers;
using Fighting.Heralds;
using Fighting.Heroes.Abstract;
using Fighting.Heroes.Concrete;
using Fighting.Weapons.Concrete;
using Fighting.Shields.Concrete;

CompetitiveHero hero = new Human("John", 100);
hero.Weapon = new Knife(4, "Knife of Dark princes");

CompetitiveHero elf = new Elf("Lorael", 120);
elf.Shield = new MagicShield("The magic shield of Lotric", 5);

var herald = new TournamentHerald();

herald.AddObserver(hero.TakePartInTournament);
herald.AddObserver(elf.TakePartInTournament);

herald.NotifyAboutTournament();

CommonFightHandler.Fight(hero, elf);