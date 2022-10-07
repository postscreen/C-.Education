import time
import re

s = 'Python is a fun programming language'
start_time = time.time()

for i in range(0,10000000):
    s.find('fun')

print("s.find: {} sec".format(time.time() - start_time))

s = 'Python is a fun programming language'
start_time = time.time()
template = re.compile(r'fun')

for i in range(0,10000000):
    result = template.match(s)

print("re.match + compile: {} sec.".format(time.time() - start_time))