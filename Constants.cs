namespace cse210_FinalProject_DragonQuest
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
      public const int MAX_X = 1200;
      public const int MAX_Y = 800;
      public const int FRAME_RATE = 30;

      public const int DEFAULT_SQUARE_SIZE = 20;
      public const int DEFAULT_FONT_SIZE = 20;
      public const int DEFAULT_TEXT_OFFSET = 4;
      public const string SOUND_START = "./Assets/start.wav";
      public const string SOUND_BOUNCE = "./Assets/boing.wav";
      public const string SOUND_OVER = "./Assets/over.wav";
      public const string IMAGE_HERO = "./Assets/Hero.png";
      public const string IMAGE_SLIME = "./Assets/slime.png";
      public const string IMAGE_DRAKEE = "./Assets/Drakee.png";
      public const string IMAGE_DRAGON = "./Assets/Dragon.png";

      public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y - 25;

        public const int BRICK_WIDTH = 48;
        public const int BRICK_HEIGHT = 24;

        public const int BRICK_SPACE = 15;

        public const int HERO_SPEED = 15;

        public const int PADDLE_WIDTH = 96;
        public const int PADDLE_HEIGHT = 24;

        public const int HERO_WIDTH = 76;
        public const int HERO_HEIGHT = 76;
        public const int SLIME_WIDTH = 57;
        public const int SLIME_HEIGHT = 61;
        public const int DRAKEE_WIDTH = 74;
        public const int DRAKEE_HEIGHT = 56;
        public const int DRAGON_WIDTH = 113;
        public const int DRAGON_HEIGHT = 93;

    }
}