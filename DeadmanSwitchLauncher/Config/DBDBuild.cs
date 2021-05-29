namespace DeadmanSwitchLauncher.Config {
    public enum DBDBuild {
        NULL,
        LIVE,
        PTB
    }

    public static class DBDBuildUtil {
        // Just an easy way to switch between Live and PTB option without having to do all the if statements.
        public static DBDBuild opposite(DBDBuild build) => build == DBDBuild.LIVE ? DBDBuild.PTB :
            build == DBDBuild.PTB ? DBDBuild.LIVE : DBDBuild.NULL;
    }
}