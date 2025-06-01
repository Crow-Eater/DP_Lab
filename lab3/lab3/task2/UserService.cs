namespace task2
{
    class UserService
    {
        private readonly ILogger logger;

        public UserService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Register(string username)
        {
            logger.Log($"Пользователь {username} зарегистрирован.");
        }
    }
}
