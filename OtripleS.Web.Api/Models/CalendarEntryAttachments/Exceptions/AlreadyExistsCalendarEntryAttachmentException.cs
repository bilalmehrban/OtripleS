﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.CalendarEntryAttachments.Exceptions
{
    public class AlreadyExistsCalendarEntryAttachmentException : Exception
    {
        public AlreadyExistsCalendarEntryAttachmentException(Exception innerException)
            : base("CalendarEntry Attachment with the same id already exists.", innerException) { }
    }
}
