using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;

namespace Uniaraxa.Service.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.AddTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _teacherRepository.DeleteTeacher(id);
        }

        public Teacher? GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }
    }
}
