﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using OtripleS.Web.Api.Models.CalendarEntryAttachments;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace OtripleS.Web.Api.Services.CalendarEntryAttachments
{
    public interface ICalendarEntryAttachmentService
    {
        ValueTask<CalendarEntryAttachment> RetrieveCalendarEntryAttachmentByIdAsync
            (Guid calendarEntryId,
             Guid attachmentId);

        IQueryable<CalendarEntryAttachment> RetrieveAllCalendarEntryAttachments();
        

    }
}
