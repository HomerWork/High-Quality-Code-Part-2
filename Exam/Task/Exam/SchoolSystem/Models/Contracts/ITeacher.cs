// <copyright file="ITeacher.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of interface ITeacher.</summary>

using SchoolSystem.Enums;

namespace SchoolSystem.Models.Contracts
{
    public interface ITeacher : IPerson
    {
        Subject Subject { get; set; }

        void AddMark(Student student, float value);
    }
}
