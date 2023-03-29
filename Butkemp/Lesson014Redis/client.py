import redis

with redis.Redis() as redis_client:
    # value = redis_client.rpop("queue")
    value = redis_client.brpop("queue") # добавили brpop для ожидания элементов очереди 


    print (int (value))