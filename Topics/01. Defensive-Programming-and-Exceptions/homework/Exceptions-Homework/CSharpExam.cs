using System;

public class CSharpExam : IExam
{
    private readonly int score;

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("Score cannot be negative!");
        }

        if (100 < score)
        {
            throw new ArgumentOutOfRangeException("Score cannot be greater than 100!");
        }

        this.score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
    }

    public ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
