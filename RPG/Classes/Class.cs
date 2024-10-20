namespace Classes
{
    public abstract class Class
    {
        #region Properties
        private string Name {  get; set; }
        private string Type {  get; set; }
        private int HP { get; set; }
        private int OriginalDefense { get; set; }
        private int Defense { get; set; }
        private int Streght { get; set; }
        private int Dexterity { get; set; }
        private int Stamina { get; set; }
        private int Magic { get; set; }
        private bool Alive { get; set; }
        private int SpecialCost { get; set; }
        #endregion

        #region Constructor
        public Class(string name, string type, int hp, int defense, int streght, int dexterity, int stamina, int magic, int specialCost)
        {
            this.Name = name;
            this.Type = type;
            this.HP = hp;
            this.Defense = defense;
            this.OriginalDefense = this.Defense;
            this.Streght = streght;
            this.Dexterity = dexterity;
            this.Stamina = stamina;
            this.Magic = magic;
            this.Alive = true;
            this.SpecialCost = specialCost;
        }
        #endregion

        #region Injector
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public string type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }
        public int hp
        {
            get { return this.HP; }
            set
            {
                if (value <= 0)
                {
                    this.Alive = false;
                }
                this.HP = value;
            }
        }
        public int originalDefense
        {
            get { return this.OriginalDefense; }
        }
        public int defense
        {
            get { return this.Defense; }
            set
            {
                if (value == this.OriginalDefense)
                {
                    this.Defense = value;
                }
            }
        }
        public int streght
        {
            get { return this.Streght; }
            set { this.Streght = value; }
        }
        public int dexterity
        {
            get { return this.Dexterity; }
            set { this.Dexterity = value; }
        }
        public int stamina
        {
            get { return this.Stamina; }
            set { this.Stamina = value; }
        }
        public int magic
        {
            get { return this.Magic; }
            set { this.Magic = value; }
        }
        public bool alive
        {
            get { return this.Alive; }
            set { this.alive = value; }
        }
        public int cost
        {
            get { return this.SpecialCost; }
            set { this.SpecialCost = value; }
        }
        #endregion

        #region abstraction
        public abstract int attack(int roll);
        #endregion

        #region SubClasses

        #region Shields
        public class Warrior: Class
        {
            private int Rage { get; set; }

            public Warrior(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                :base("The Warrior", "Shield", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Rage = rage;
            }

            public int rage
            {
                get { return this.Rage; }
                set { this.Rage = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        public class Paladin: Class
        {
            private int Holy { get; set; }

            public Paladin(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                :base("Holy Knight", "Shield", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Holy = rage;
            }

            public int holy
            {
                get { return this.Holy; }
                set { this.Holy = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #region Vanguard
        public class Swordsman: Class
        {
            private int Focus { get; set; }

            public Swordsman(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                :base("Sword Master", "Vanguard", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Focus = rage;
            }

            public int focus
            {
                get { return this.Focus; }
                set { this.Focus = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        public class Assassin: Class
        {
            private int Stealth { get; set; }

            public Assassin(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                :base("Assassin", "Vanguard", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Stealth = rage;
            }

            public int stealth
            {
                get { return this.Stealth; }
                set { this.Stealth = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #region Ofensive
        public class Archer : Class
        {
            private int Arrows { get; set; }

            public Archer(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                : base("The Green Arrow", "Ofensive", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Arrows = rage;
            }

            public int arrows
            {
                get { return this.Arrows; }
                set { this.Arrows = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        public class Mage : Class
        {
            private int Mana { get; set; }

            public Mage(int hp, int defense, int streght, int dexterity, int stamina, int magic, int rage)
                : base("The Sage", "Ofensive", hp, defense, streght, dexterity, stamina, magic, 10)
            {
                this.Mana = rage;
            }

            public int mana
            {
                get { return this.Mana; }
                set { this.Mana = value; }
            }
            public override int attack(int roll)
            {
                //attack damage for each class
                return 0;
            }
        }
        #endregion

        #endregion
    }
}
