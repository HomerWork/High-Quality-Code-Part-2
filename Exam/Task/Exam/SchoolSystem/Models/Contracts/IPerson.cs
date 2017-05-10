// <copyright file="IPerson.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of interface IPerson.</summary>

namespace SchoolSystem.Models.Contracts
{
    /// <summary>
    /// Defines gets and sets of the <see cref="IPerson"/> heir's FirstName and LastName.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets and sets of the <see cref="IPerson"/> heir's FirstName.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets and sets of the <see cref="IPerson"/> heir's LastName.
        /// </summary>
        string LastName { get; set; }
    }
}
