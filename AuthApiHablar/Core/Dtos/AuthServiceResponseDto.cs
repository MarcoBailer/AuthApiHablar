﻿namespace AuthApiHablar.Core.Dtos
{
    public class AuthServiceResponseDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string UserId { get; set; }
    }
}
