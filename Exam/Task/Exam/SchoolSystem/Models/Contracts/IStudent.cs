// <copyright file="IStudent.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of interface IStudent.</summary>

using SchoolSystem.Enums;

namespace SchoolSystem.Models.Contracts
{
    public interface IStudent : IPerson
    {
        Grade Grade { get; }

        void AddMark(Mark mark);

        string ListMarks();
    }
}
