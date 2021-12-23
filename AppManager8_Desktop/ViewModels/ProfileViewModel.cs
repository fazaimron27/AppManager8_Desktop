using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppManager8_Desktop.Models;

namespace AppManager8_Desktop.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel()
        {
    
        }

        public bool Create(Profile profile)
        {
            var query = $"INSERT INTO profile (guid, username, alias, keypass) " +
                $"VALUES ('{profile.Guid}', '{profile.Username}', '{profile.Alias}', '{profile.KeyPass}')";

            if (OpenConnection())
            {
                var command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
            }
            CloseConnection();
            return true;
        }
        
        public IEnumerable<Profile> Read()
        {
            var profiles = new List<Profile>();
            var query = "SELECT * FROM profile";

            if (OpenConnection())
            {
                var command = new SqlCommand(query, Connection);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var profile = new Profile
                        {
                            Uid = Convert.ToInt32(reader["uid"]),
                            Guid = reader["guid"].ToString(),
                            Username = reader["username"].ToString(),
                            Alias = reader["alias"].ToString(),
                            KeyPass = reader["keypass"].ToString()
                        };
                        profiles.Add(profile);
                    }
                }
            }
            CloseConnection();
            return profiles;
        }
        
        public bool Update(Profile profile)
        {
            var query = $"UPDATE profile SET " +
                $"guid = '{profile.Guid}', " +
                $"username = '{profile.Username}', " +
                $"alias = '{profile.Alias}', " +
                $"keypass = '{profile.KeyPass}' " +
                $"WHERE uid = {profile.Uid}";

            if (OpenConnection())
            {
                var command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
            }
            CloseConnection();
            return true;
        }
        
        public bool Delete(Profile profile)
        {
            var query = $"DELETE FROM profile WHERE uid = {profile.Uid}";

            if (OpenConnection())
            {
                var command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
            }
            CloseConnection();
            return true;
        }
    }
}
