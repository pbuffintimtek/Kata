using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Bowling.Models
{
    public class Line
    {
        public List<Frame> Frames { get; set; }

        public Line()
        {
            Frames = new List<Frame>();
        }

        public static Line Create()
        {
            return new Line();
        }

        public Line AddScore(int score)
        {
            var last = Frames.LastOrDefault();

            if (Frames.Count == 10 && last.IsClose())
            {
                last.AddBonus(score);
                return this;
            }

            if (last != null && !last.SecondScore.HasValue && (last.FirstScore != 10 || Frames.Count == 10 && last.FirstScore == 10))
            {
                last.AddSecondeScore(score);

            }
            else
            {
                var frame = Frame.Create(score);
                Frames.Add(frame);
            }
            return this;
        }

        public int TotalScore()
        {
            var score = 0;

            for (var i = 0; i < Frames.Count; i++)
            {
                if (Frames[i].IsStrick())
                {
                    if (Frames[i + 1].IsStrick())
                    {
                        score += Frames[i].Total() + Frames[i+1].Total() + Frames[i+2].Total();
                    }
                    else
                    {
                        score += Frames[i].Total() + Frames[i + 1].Total();
                    }
                }
                else if (Frames[i].IsSpare())
                {
                    score += i != 9 ? Frames[i].Total() + Frames[i + 1].FirstScore : Frames[i].Total();
                }
                else
                {
                    score += Frames[i].Total();
                }
            }

            return score;
        }
    }
}
