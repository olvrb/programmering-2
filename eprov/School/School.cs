using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eprov.School.Classroom;

namespace eprov.School
{
    public class School {
        public IReadOnlyList<Classroom.Classroom> Classrooms => classrooms.AsReadOnly();
        private readonly List<Classroom.Classroom> classrooms = new List<Classroom.Classroom> { };

        public School() {
            classrooms.AddRange(new[] {
                new Classroom.Classroom("MusicRoom", 15),
                new Classroom.Classroom("ChemistryRoom", 15),
                new Classroom.Classroom("MathRoom", 45)
            });
        }
    }
}
