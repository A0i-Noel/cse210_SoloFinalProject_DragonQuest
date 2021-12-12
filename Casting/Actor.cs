using System;
using System.Collections.Generic;

namespace cse210_FinalProject_DragonQuest.Casting
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;
        protected int _lv = 0;
        protected int _EXP = 0;
        protected List<int> _NeedEXP = new List<int>();
        protected int _HP = 0;
        protected int _MP = 0;
        protected int _MAX_HP = 0;
        protected int _MAX_MP = 0;
        protected int _Mighty = 0;
        protected int _width = 0;
        protected int _height = 0;
        protected bool redText = false;
        protected int OLD_x;
        protected int OLD_y;

        protected string _text = "";
        private string _image = "";

        public Actor()
        {
            // Start these at 0, 0 by default
            _position = new Point(0, 0);
            _velocity = new Point(0, 0);
        }


        public void SetImage(string image)
        {
            _image = image;
        }

        public string GetImage()
        {
            return _image;
        }

        public bool HasImage()
        {
            return _image != "";
        }

        public bool HasText()
        {
            return _text != "";
        }

        public bool RedText()
        {
            return redText;
        }

        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetOLD_X()
        {
            return _position.GetOLD_X();
        }

        public int GetOLD_Y()
        {
            return _position.GetOLD_Y();
        }

        public int SetOLD_X(int old_x)
        {
            return OLD_x = old_x;
        }

        public int SetOLD_Y(int old_y)
        {
            return OLD_y = old_y;
        }

        public int GetLeftEdge()
        {
            return _position.GetX();
        }

        public int GetRightEdge()
        {
            return _position.GetX() + _width;
        }

        public int GetTopEdge()
        {
            return _position.GetY();
        }

        public int GetBottomEdge()
        {
            return _position.GetY() + _height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public void SetPosition(Point position)
        {
            _position = position;
        }

        public void Delete()
        {

        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }

        public int GetHP()
        {
            return _HP;
        }

        public void SetHP(int HP)
        {
            _HP = HP;
        }

        public int GetMAX_HP()
        {
            return _MAX_HP;
        }

        public void SetMAX_HP(int MAX_HP)
        {
            _MAX_HP = MAX_HP;
        }

        public int GetMP()
        {
            return _MP;
        }

        public void SetMP(int MP)
        {
            _MP = MP;
        }

        public int GetMAX_MP()
        {
            return _MAX_MP;
        }

        public void SetMAX_MP(int MAX_MP)
        {
            _MAX_MP = MAX_MP;
        }

        public int GetMighty()
        {
            return _Mighty;
        }

        public void SetMighty(int mighty)
        {
            _Mighty = mighty;
        }

        public int GetLevel()
        {
            return _lv;
        }

        public void SetLevel(int lv)
        {
            _lv = lv;
        }

        public int GetEXP()
        {
            return _EXP;
        }

        public void SetEXP(int EXP)
        {
            _EXP = EXP;
        }

        public List<int> GetNeedEXP()
        {
            return _NeedEXP;
        }

        public void SetNeedEXP(int EXP0, int EXP1, int EXP2, int EXP3, int EXP4, int EXP5, int EXP6, int EXP7, int EXP8, int EXP9)
        {
            _NeedEXP.Add(EXP0);
            _NeedEXP.Add(EXP1);
            _NeedEXP.Add(EXP2);
            _NeedEXP.Add(EXP3);
            _NeedEXP.Add(EXP4);
            _NeedEXP.Add(EXP5);
            _NeedEXP.Add(EXP6);
            _NeedEXP.Add(EXP7);
            _NeedEXP.Add(EXP8);
            _NeedEXP.Add(EXP9);

        }


        public void MoveNext()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            // int dx = _velocity.GetX();
            // int dy = _velocity.GetY();

            // int newX = (x + dx) % Constants.MAX_X;
            // int newY = (y + dy) % Constants.MAX_Y;

            // if (newX < 0)
            // {
            //     newX = Constants.MAX_X;
            // }

            // if (newY < 0)
            // {
            //     newY = Constants.MAX_Y;
            // }

            _position = new Point(x, y);
        }

        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

    }

}