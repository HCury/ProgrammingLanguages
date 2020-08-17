carSpeeds <- read.csv(file = 'review.csv', stringsAsFactors = FALSE)
filter <- carSpeeds$overall >= 4
str(carSpeeds[filter,])
