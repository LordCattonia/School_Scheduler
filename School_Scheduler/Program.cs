
using System.Dynamic;

namespace School_Scheduler
{
    public class general_input
    {
        public class teacher_input
        {
            // Receives information from MS Forms

            // Get teachers, then array in data type string[teacher[subject...],teacher[subject...]]
        }

        public class student_input
        {
            // Receives information from MS Forms

            // Get student's class preference string[student[classid*14]]

            // Then get students person preferences: first make array of string[(student,weighting)]
            // followed by string[student[friend*3]] maybe create relational database and graph for fun?

        }
    }
    public class resource_storage
    {
        // Array of rooms: work with classes and teachers to find rooms. Try to limit walking seniorside.
    }

    public class schedule_storage
    {
        // Get inputs and make the actual DBs of teacher, student and room schedules along with class lists.
    }

    public class schedule_output
    {
        // Output to compass database of teacher schedules, student schedules, room schedules and class lists.

        // Give to coordinators cloud based weighting list as a threat to students.
    }
}