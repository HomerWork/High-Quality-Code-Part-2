// <copyright file="IMark.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of interface IMark.</summary>

using SchoolSystem.Enums;

namespace SchoolSystem.Models.Contracts
{
    public interface IMark
    {
        float Value { get; set; }

        Subject Subject { get; set; }
    }
}
