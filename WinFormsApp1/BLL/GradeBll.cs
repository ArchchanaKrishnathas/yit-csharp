using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using WinFormsApp1.DAL;
using System.Threading.Tasks;

namespace WinFormsApp1.BLL
{
    public class GradeBll
    {
        private readonly GradeDal gradeDal = new GradeDal();

        // READ: all grades
        public Task<DataTable> GetAllAsync()
        {
            return gradeDal.GetAll();
        }

        // READ: one grade
        public Task<DataTable> GetByIdAsync(string id)
        {
            ValidateId(id);
            return gradeDal.GetByID(id);
        }

        // CREATE
        public Task<int> CreateAsync(
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            ValidateGrade(gradeName, gradeGroup, gradeOrder, colour);

            return gradeDal.Store(
                gradeName.Trim(),
                gradeGroup.Trim(),
                gradeOrder.Trim(),
                colour);
        }

        // UPDATE
        public Task<int> UpdateAsync(
            string id,
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            ValidateId(id);
            ValidateGrade(gradeName, gradeGroup, gradeOrder, colour);

            return gradeDal.Update(
                id,
                gradeName.Trim(),
                gradeGroup.Trim(),
                gradeOrder.Trim(),
                colour);
        }

        // DELETE
        public Task<int> DeleteAsync(string id)
        {
            ValidateId(id);
            return gradeDal.Delete(id);
        }

        private static void ValidateId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Please select a grade.");
        }

        private static void ValidateGrade(
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            if (string.IsNullOrWhiteSpace(gradeName))
                throw new ArgumentException("Please enter the grade name.");

            if (string.IsNullOrWhiteSpace(gradeGroup))
                throw new ArgumentException("Please enter the grade group.");

            if (!int.TryParse(gradeOrder, out int order) || order < 0)
                throw new ArgumentException("Grade order must be a non-negative whole number.");

            if (string.IsNullOrWhiteSpace(colour) ||
                !Regex.IsMatch(colour, @"^#[0-9A-Fa-f]{6}$"))
                throw new ArgumentException("Please choose a valid colour.");
        }
    }
}
