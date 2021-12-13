namespace cse210_FinalProject_DragonQuest
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
      public const int MAX_X = 6000;
      public const int MAX_Y = 4000;
      public const int Screen_X = 1200;
      public const int Screen_Y = 800;
      public const int FRAME_RATE = 30;

      public const int DEFAULT_SQUARE_SIZE = 20;
      public const int DEFAULT_FONT_SIZE = 30;
      public const int DEFAULT_TEXT_OFFSET = 4;
      public const string SOUND_START = "./Assets/Openning.wav";
      public const string SOUND_ATTACK = "./Assets/AttackAudio.wav";
      public const string SOUND_SPELL = "./Assets/Spell.wav";
      public const string SOUND_LEVELUP = "./Assets/LevelUp.wav";
      public const string SOUND_FIELD = "./Assets/FieldAudio.wav";
      public const string SOUND_OVER = "./Assets/GameOver.wav";
      public const string IMAGE_TREE = "./Assets/Tree.png";
      public const string IMAGE_WATER = "./Assets/water.png";
      public const string IMAGE_SEA = "./Assets/Sea.png";
      public const string IMAGE_FIELD = "./Assets/Field.png";
      public const string IMAGE_DESERT = "./Assets/Desert.png";
      public const string IMAGE_SMOUNTAIN = "./Assets/SmallMountain.png";
      public const string IMAGE_HMOUNTAIN = "./Assets/HugeMountain.png";
      public const string IMAGE_BLACK = "./Assets/Black.png";
      public const string IMAGE_HERO = "./Assets/Hero.png";
      public const string IMAGE_SLIME = "./Assets/slime.png";
      public const string IMAGE_DRAKEE = "./Assets/Drakee.png";
      public const string IMAGE_DRAGON = "./Assets/Dragon.png";
      public const string IMAGE_ATTACK = "./Assets/sword.png";
      public const string IMAGE_HERB = "./Assets/HARB.png";
      public const string IMAGE_BOARD = "./Assets/Billboard.png";

      public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y - 25;

        public const int BRICK_SPACE = 15;

        public const int HERO_SPEED = 15;
        public const int SCREEN_WIDTH = 1200;
        public const int SCREEN_HEIGHT = 800;
        

        public const int MAP_WIDTH = 76;
        public const int MAP_HEIGHT = 76;
        public const int MAP_SPEED = 15;
        public const int HERO_WIDTH = 60;
        public const int HERO_HEIGHT = 60;
        public const int SLIME_WIDTH = 57;
        public const int SLIME_HEIGHT = 61;
        public const int SLIME_SPEED = 15;
        public const int SLIME_MIGHTY = 2;
        public const int SLIME_LIFE = 10;
        public const int DRAKEE_WIDTH = 74;
        public const int DRAKEE_HEIGHT = 56;
        public const int DRAKEE_SPEED = 15;
        public const int DRAKEE_MIGHTY = 4;
        public const int DRAKEE_LIFE = 15;
        public const int DRAGON_WIDTH = 150;
        public const int DRAGON_HEIGHT = 150;
        public const int DRAGON_SPEED = 15;
        public const int DRAGON_MIGHTY = 20;
        public const int DRAGON_LIFE = 150;
        public const int SLIME_MAX_NUMBER = 150;
        public const int DRAKEE_MAX_NUMBER = 100;
        public const int DRAGON_MAX_NUMBER = 1;
        public const int ATTACK_HEIGHT = 76;
        public const int ATTACK_WIDTH = 76;
        public const string TEXT_INTRO = "./Assets/Intro.txt";

    }
}