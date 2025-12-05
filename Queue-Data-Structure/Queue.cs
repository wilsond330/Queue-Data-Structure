using System;

public class Queue<queueType>
{
	private int MAX_SIZE;
	private bool isEmpty;
	private bool isFull;
	private queueType[] arrayUsedInQueue;
	private int front;
	private int back;
	public Queue(int maxSize)
	{
		this.MAX_SIZE = maxSize;
		this.isEmpty = true;
		this.isFull = false;
		arrayUsedInQueue = new queueType[MAX_SIZE];
		front = 0;
		back = 0;
	}
	public (queueType, bool) DeQueue()
	{
		bool successful = false;
		queueType output = default(queueType);
        if (!isEmpty)
        {
            output = arrayUsedInQueue[front];
            isFull = false;
            front = (front + 1) % MAX_SIZE;
            if (front == back)
            {
                isEmpty = true;
            }
            successful = true;
        }
		else
		{
			successful = false;
		}
		return (output, successful);
	}
	public bool EnQueue(queueType input)
	{
		bool successful;
		if (!isFull)
		{
            arrayUsedInQueue[back] = input;
            back = (back + 1) % MAX_SIZE;
            isEmpty = false;
            if (front == back)
            {
                isFull = true;
            }
			successful = true;
        }
		else
		{
			successful = false;
		}
		return successful;
	}
	public bool IsEmpty()
	{
		return isEmpty;
	}
	public bool IsFull()
	{
		return isFull;
	}
}
