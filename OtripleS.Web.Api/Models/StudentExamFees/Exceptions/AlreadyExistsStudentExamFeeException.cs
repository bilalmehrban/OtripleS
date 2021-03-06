﻿//---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
//----------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.StudentExamFees.Exceptions
{
    public class AlreadyExistsStudentExamFeeException : Exception
    {
        public AlreadyExistsStudentExamFeeException(Exception innerException)
            : base("StudentExamFee with the same id already exists.", innerException) { }
    }
}
