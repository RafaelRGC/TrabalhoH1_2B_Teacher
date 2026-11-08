using Uniaraxa.Domain.Entities;

namespace Uniaraxa.Service.Services
{
    public interface ITeacherService
    {
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int id);
        Teacher? GetTeacherById(int id);
        List<Teacher> GetAllTeachers();
    }
}
