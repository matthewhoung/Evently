﻿using Evently.Common.Domain.Abstractions.Errors;

namespace Evently.Modules.Attendance.Domain.Attendees;

public static class AttendeeErrors
{
    public static Error NotFound(Guid attendeeId) =>
        Error.NotFound("Attendees.NotFound", $"The attendee with the identifier {attendeeId} was not found");
}
