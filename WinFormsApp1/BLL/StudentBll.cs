using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WinFormsApp1.DAL;

namespace WinFormsApp1.BLL
{
    public class StudentBll
    {
        private readonly StudentDal studentDal = new StudentDal();

        // READ: all students
        public Task<DataTable> GetAllAsync()
        {
            return studentDal.GetAll();
        }

        // READ: one student
        public Task<DataTable> GetByIdAsync(string id)
        {
            ValidateId(id);
            return studentDal.GetByID(id);
        }

        // CREATE
        public Task<int> CreateAsync(
            string firstName,
            string lastName,
            string address,
            int gradeId,
            int houseId,
            string medium,
            DateTime dateOfBirth,
            int familyId,
            string gender,
            string admissionNumber,
            string nicNumber,
            string birthCertificateNumber,
            string telephoneNumber)
        {
            ValidateStudent(firstName, lastName, gradeId, houseId,
                medium, gender, admissionNumber);

            if (familyId <= 0)
                throw new ArgumentException("A valid family is required.");

            return studentDal.Store(
                firstName.Trim(),
                lastName.Trim(),
                address.Trim(),
                gradeId,
                houseId,
                medium.Trim(),
                dateOfBirth.Date,
                familyId,
                gender,
                admissionNumber.Trim(),
                nicNumber.Trim(),
                birthCertificateNumber.Trim(),
                telephoneNumber.Trim());
        }

        // UPDATE: object parameters match your existing StudentDal.Update
        public Task<int> UpdateAsync(
            string id,
            string firstName,
            string lastName,
            string address,
            object gradeId,
            object houseId,
            string medium,
            DateTime dateOfBirth,
            object familyId,
            string gender,
            string admissionNumber,
            string nicNumber,
            string birthCertificateNumber,
            string telephoneNumber)
        {
            ValidateId(id);

            if (gradeId == null || gradeId == DBNull.Value ||
                houseId == null || houseId == DBNull.Value)
                throw new ArgumentException("Please select a grade and house.");

            int selectedGradeId = Convert.ToInt32(gradeId);
            int selectedHouseId = Convert.ToInt32(houseId);

            ValidateStudent(firstName, lastName, 1, 1,
                medium, gender, admissionNumber);

            return studentDal.Update(
                id,
                firstName.Trim(),
                lastName.Trim(),
                address.Trim(),
                selectedGradeId,
                selectedHouseId,
                medium.Trim(),
                dateOfBirth.Date,
                familyId,
                gender,
                admissionNumber.Trim(),
                nicNumber.Trim(),
                birthCertificateNumber.Trim(),
                telephoneNumber.Trim());
        }

        // DELETE
        public Task<int> DeleteAsync(string id)
        {
            ValidateId(id);
            return studentDal.Delete(id);
        }

        private static void ValidateId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Please select a student.");
        }

        private static void ValidateStudent(
            string firstName,
            string lastName,
            int gradeId,
            int houseId,
            string medium,
            string gender,
            string admissionNumber)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Please enter the first name.");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Please enter the last name.");

            if (gradeId <= 0)
                throw new ArgumentException("Please select a grade.");

            if (houseId <= 0)
                throw new ArgumentException("Please select a house.");

            if (string.IsNullOrWhiteSpace(medium))
                throw new ArgumentException("Please select a medium.");

            if (gender != "M" && gender != "F")
                throw new ArgumentException("Please select a gender.");

            if (string.IsNullOrWhiteSpace(admissionNumber))
                throw new ArgumentException("Please enter the admission number.");
        }
    
    }
}
