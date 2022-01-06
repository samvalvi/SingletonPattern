using SingletonPattern.Pattern;

var singleton = Singleton.Instance;

var msg = Log.Instance;
msg.Save("Hello World!");
