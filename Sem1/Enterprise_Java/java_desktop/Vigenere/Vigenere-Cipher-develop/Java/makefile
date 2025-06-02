all: build run

build:
	@echo "Compiling..." && \
	javac -d ./build ./vigenere/*.java && \
	echo "Finish"

run:
	@cd build && \
	java Java.vigenere.Main

clean:
	@rm -rf build
	@echo "build removed"



