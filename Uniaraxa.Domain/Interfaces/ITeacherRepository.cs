using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Domain.Interfaces
{
    public interface ITeacherRepository
    {
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        Teacher? GetTeacherById(int id);
        List<Teacher> GetAllTeachers();
    }
}
