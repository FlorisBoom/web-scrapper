﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MangaAlert.Dtos
{
  public record AlertDto
  {
    [Required]
    public Guid Id { get; init; }

    [Required]
    public string Title { get; init; }

    [Required]
    public string Url { get; init; }

    public DateTimeOffset? LatestChapterUpdatedAt { get; init; }

    public int LatestChapter { get; init; }

    public bool HasReadLatestChapter { get; init; }

    public bool HasCompleted { get; init; }

    public DateTimeOffset? CompletedAt { get; init; }

    public string Status { get; init; }

    public DateTimeOffset? CreatedAt { get; init; }

    [Required]
    public Guid UserId { get; init; }
   }
}
