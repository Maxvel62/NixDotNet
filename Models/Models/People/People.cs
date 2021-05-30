﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace Models.People
{
    /// <summary>
    /// Contains a list of people and allows you to check the uniqueness of the login and password.
    /// </summary>
    internal static class People
    {
        #region Fields
        /// <summary>
        /// List of all humans.
        /// </summary>
        private static readonly List<Person> Humans = new List<Person>();
        #endregion
        #region Methods
        /// <summary>
        /// Add new person to Humans list.
        /// </summary>
        /// <param name="person">Person</param>
        internal static void AddPerson(Person person)
        {
            if (person != null)
            {
                Humans.Add(person);
                return;
            }
            throw new ArgumentNullException(nameof(person), "Person can't be null");
        }
        /// <summary>
        /// Check if the login is free.
        /// </summary>
        /// <param name="login">Login</param>
        /// <returns></returns>
        internal static bool CheckLoginAvailability(string login)=> !Humans.Select(c => c.Login).Contains(login);
        /// <summary>
        /// Check if the email is free.
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns></returns>
        internal static bool CheckEmailAvailability(string email)=> !Humans.Select(c => c.Email).Contains(email);
        #endregion
        
    }
}