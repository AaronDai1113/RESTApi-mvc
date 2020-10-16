using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo{
        IEnumerable<Command> GetAllCpmmands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        bool SaveChanges();
        void UpdateCommand(Command cmd);
    }
}