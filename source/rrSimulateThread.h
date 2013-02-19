#ifndef rrSimulateThreadH
#define rrSimulateThreadH
#include <list>
#include "rrRoadRunnerThread.h"
#include "Poco/Condition.h"
//---------------------------------------------------------------------------

namespace rr
{

using std::list;
using Poco::Mutex;
using Poco::Condition;

class RR_DECLSPEC SimulateThread : public RoadRunnerThread
{

	protected:
        static list<RoadRunner*>    mJobs;
		static Mutex	 			mJobsMutex;
    	static Condition			mJobsCondition;
        void						signalAll();
        void						signalExit();

	public:
    								SimulateThread();
    	void 						worker();
		void 			            addJob(RoadRunner* rr);
		unsigned int  				getNrOfJobsInQueue();
};

}
#endif
