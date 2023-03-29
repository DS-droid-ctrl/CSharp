import redis
import random # для подставление рандомных значений

# redis_server = redis.Redis()

# redis_server.close()

with redis.Redis() as redis_server:
    # redis_server.lpush("queue", 1)

    redis_server.lpush("queue", random.randint(0, 10))