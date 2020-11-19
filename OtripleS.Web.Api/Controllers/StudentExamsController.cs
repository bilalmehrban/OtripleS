﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtripleS.Web.Api.Models.StudentExams;
using OtripleS.Web.Api.Models.StudentExams.Exceptions;
using OtripleS.Web.Api.Services.StudentExams;
using RESTFulSense.Controllers;

namespace OtripleS.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentExamsController : RESTFulController
    {
        private readonly IStudentExamService studentExamService;

        public StudentExamsController(IStudentExamService studentExamService) =>
            this.studentExamService = studentExamService;

        [HttpPost]
        public async ValueTask<ActionResult<StudentExam>> PostStudentExamAsync(
            StudentExam studentExam)
        {
            try
            {
                StudentExam persistedStudentExam =
                    await this.studentExamService.CreateStudentExamAsync(studentExam);

                return Ok(persistedStudentExam);
            }
            catch (StudentExamValidationException studentExamValidationException)
                when (studentExamValidationException.InnerException is AlreadyExistsStudentExamException)
            {
                string innerMessage = GetInnerMessage(studentExamValidationException);

                return Conflict(innerMessage);
            }
            catch (StudentExamValidationException studentExamValidationException)
            {
                string innerMessage = GetInnerMessage(studentExamValidationException);

                return BadRequest(innerMessage);
            }
            catch (StudentExamDependencyException studentExamDependencyException)
            {
                return Problem(studentExamDependencyException.Message);
            }
            catch (StudentExamServiceException studentExamServiceException)
            {
                return Problem(studentExamServiceException.Message);
            }
        }

        private static string GetInnerMessage(Exception exception) =>
            exception.InnerException.Message;
    }
}