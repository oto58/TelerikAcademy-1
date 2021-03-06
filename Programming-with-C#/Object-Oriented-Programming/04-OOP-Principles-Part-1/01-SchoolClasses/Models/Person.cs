﻿namespace SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using SchoolClasses.Contracts;

    public abstract class Person : IHaveComments
    {
        private const string NameNullExceptionMsg = "Name cannot be empty.";

        private string firstName;
        private string lastName;
        private ICollection<Comment> comments;

        protected Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Comments = new HashSet<Comment>();
        }

        [Required]
        [MinLength(3), StringLength(15)]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullExceptionMsg);
                }

                this.firstName = value;
            }
        }

        [Required]
        [MinLength(3), StringLength(15)]
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(NameNullExceptionMsg);
                }

                this.lastName = value;
            }
        }

        public virtual ICollection<Comment> Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                this.comments = value;
            }
        }

        public void AddComment(Comment comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
