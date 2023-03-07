using System;

namespace Kata.Bowling.Models
{
    public class Frame
    {
        public Frame(int score)
        {
            FirstScore = score;
            BonusScore = 0;
        }

        public int? SecondScore { get; internal set; }
        public int FirstScore { get; internal set; }
        public int BonusScore { get; private set; }

        public static Frame Create(int score)
        {
            return new Frame(score);
        }

        public bool IsClose()
        {
            return FirstScore + SecondScore == 10;
        }

        public void AddBonus(int score)
        {
            BonusScore = score;
        }

        public void AddSecondeScore(int score)
        {
            SecondScore = score;
        }

        public bool IsSpare()
        {
            return FirstScore + SecondScore >= 10;
        }

        public int Total()
        {
            return FirstScore + (SecondScore.HasValue ? SecondScore.Value : 0) + BonusScore;
        }

        public bool IsStrick()
        {
            return FirstScore == 10;
        }
    }
}