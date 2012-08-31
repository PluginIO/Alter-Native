#pragma once
#include "../IDisposable.h"
#include "../String.h"

namespace System_IO {
class TextReader : public IDisposable, public virtual gc_cleanup {
public:	
	void Dispose();
	virtual void Dispose(bool disposing);
	virtual int Peek();
	virtual int Read();
	virtual int Read(char* buffer, int index, int count);
	virtual String* ReadToEnd();
	virtual int ReadBlock(char* buffer, int index, int count);
	virtual String* ReadLine();
	virtual void Close();
};
}