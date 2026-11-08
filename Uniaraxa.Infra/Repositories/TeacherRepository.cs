using Uniaraxa.Domain.Entities;
using Uniaraxa.Domain.Interfaces;

namespace Uniaraxa.Infra.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private static readonly List<Teacher> _teachers = new();

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            var existingTeacher = _teachers.FirstOrDefault(t => t.Id == teacher.Id);

            if (existingTeacher != null)
            {
                existingTeacher.Name = teacher.Name;
                existingTeacher.EMail = teacher.EMail;
                existingTeacher.UrlLattes = teacher.UrlLattes;
                existingTeacher.DataAdmissao = teacher.DataAdmissao;
            }
        }

        public void DeleteTeacher(int id)
        {
            var teacher = _teachers.FirstOrDefault(t => t.Id == id);

            if (teacher != null)
            {
                _teachers.Remove(teacher);
            }
        }

        public Teacher? GetTeacherById(int id)
        {
            return _teachers.FirstOrDefault(t => t.Id == id);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teachers;
        }
    }
}
