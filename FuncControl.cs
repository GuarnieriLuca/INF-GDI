using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI3
{
    public delegate double Function2D(double x);
    //draw a generic y=f(x)

    class FuncControl:Control
    {
        int _ScaleFactor = 10; // 10px per unità
        Function2D _f;

        public Function2D Func
        {
            get { return _f; }
            set { _f = value; Refresh(); }
        }
        public FuncControl()
        {
            _f = (x) => 0; //y=0;
            //_f = Math.Sin; // double Sin(double a);
            //_f = (x) => x * x; //lambda double q (double x){return x*x;}; _f=q;
            //_f = (x) => Math.Pow(x, 2); // Pow non ha la stessa signature del delegate

            //_f = Math.Sqrt;
            //_f = (x) => Math.Sqrt(x);
            //_f = (x) => { double y = Math.Sqrt(x); return y + 2; };
            //_f = Foo;

            //double y = _f(2.5);
        }

        //public double Foo(double t)
        //{
        //    return Math.PI * t / 100;
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            double h2 = Height / 2.0;
            double w2 = Width / 2.0;

            var g = e.Graphics;

            var p = new Pen(ForeColor);

            g.DrawLine(p, 0, (float)h2, Width -1, (float)h2); //x
            g.DrawLine(p,  (float)w2,0, (float)w2, Height - 1); //x

            if (_f == null) return;

            var lp = new List<Point>();

            const int xstep= 1;
            for (int xc = 0; xc < Width+xstep; xc+=xstep) //ogni 5px
            {
                double x = (double)(xc - w2) / _ScaleFactor;
                double y=_f (x) ;
                // x,y => xc,h2-scale*y
                int yc = (int)(h2 - _ScaleFactor * y);

                lp.Add(new Point(xc,yc));
            }


            g.DrawLines(p, lp.ToArray());

        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (e.Delta > 0) _ScaleFactor++;
            else if (_ScaleFactor > 1) _ScaleFactor--;

            Refresh();
        }
    }
}
