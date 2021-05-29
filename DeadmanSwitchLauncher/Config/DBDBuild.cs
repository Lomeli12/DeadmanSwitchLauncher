namespace DeadmanSwitchLauncher.Config {
    public enum DBDBuild {
        NULL,
        LIVE,
        PTB
    }

    public static class DBDBuildUtil {
        public static DBDBuild opposite(DBDBuild build) => build == DBDBuild.LIVE ? DBDBuild.PTB :
            build == DBDBuild.PTB ? DBDBuild.LIVE : DBDBuild.NULL;
    }
}