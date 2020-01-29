using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eprov.School.Classroom;

namespace eprov.School
{
    public class School {
        // Only give the user a readonly list
        public IReadOnlyList<Classroom.Classroom> Classrooms => classrooms.AsReadOnly();

        // Keep the read-write list as a private field
        private readonly List<Classroom.Classroom> classrooms = new List<Classroom.Classroom> { };

        public School() {
            // Add all the desired rooms
            classrooms.AddRange(new[] {
                new Classroom.Classroom("MusicRoom", 15),
                new Classroom.Classroom("ChemistryRoom", 15),
                new Classroom.Classroom("MathRoom", 45)
            });
        }
    }
}
