using Log;

Logger logger = new Logger("Sistem baslatildi.");
logger.Log();

// FileLogger
var fileLogger = new FileLogger("Kullanici giris yapti.");
fileLogger.Log();

// SecureFileLogger
var secureFileLogger = new SecureFileLogger("Yetkisiz erisim denemesi!", "secure_log.txt");
secureFileLogger.Log();
