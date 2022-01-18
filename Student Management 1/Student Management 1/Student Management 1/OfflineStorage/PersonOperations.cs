using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student_Management_1
{
  public class PersonOperations
    {
        public static Task<List<Person>> GetPersonAsync()
        {
            //Get all notes.
            return App.DatabaseConnection.Table<Person>().ToListAsync();
        }

        public static Task<Person> GetPersonAsync(int id)
        {
            // Get a specific note.
            return App.DatabaseConnection.Table<Person>()
                            .FirstOrDefaultAsync(i => i.ID == id);
        }

        public static Task<int> InsertOrUpdatePersonAsync(Person note)
        {
            if (note.ID != 0)
            {
                // Update an existing note.
                return App.DatabaseConnection.UpdateAsync(note);
            }
            else
            {
                // Save a new note.
                return App.DatabaseConnection.InsertAsync(note);
            }
        }

        public static Task<int> DeletePersonAsync(Person note)
        {
            // Delete a note.
            return App.DatabaseConnection.DeleteAsync(note);
        }
    }
}