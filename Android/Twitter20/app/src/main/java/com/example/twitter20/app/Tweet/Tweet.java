package com.example.twitter20.app.Tweet;

class Tweet {

    int ID;
    String TweetText;
    String TweetImage;

    int TweetLikeCount;
    int TweetCommentCount;
    int TweetShareCount;

    public Tweet(String tweetText, String tweetImage) {

        TweetText = tweetText;
        TweetImage = tweetImage;
    }

    public int getID() {
        return ID;
    }

    public Tweet() {

    }

    public String getTweetText() {
        return TweetText;
    }

    public void setTweetText(String tweetText) {
        TweetText = tweetText;
    }

    public String getTweetImage() {
        return TweetImage;
    }

    public void setTweetImage(String tweetImage) {
        TweetImage = tweetImage;
    }
}
