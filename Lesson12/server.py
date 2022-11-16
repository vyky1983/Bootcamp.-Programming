import redis
import random

with redis.Redis() as redis_server:

# redis_server = redis.Redis()

redis_server.lpush("Q",1)