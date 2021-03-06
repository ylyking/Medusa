// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
#pragma once
#include "Resource/Timeline/ITimelineModel.h"

MEDUSA_BEGIN;

class IKTimelineModel:public ITimelineModel
{
public:
	IKTimelineModel(const FileIdRef& fileId, float duration = 0.f);
	virtual ~IKTimelineModel(void);

	void AddData(float time, float mix,bool isBlendPositive, Math::TweenType tweenType, const List<float>& args);

	float GetMix(float time)const;
	bool IsBlendPositive(float time)const;
	virtual void RemovePrecomputed()override;
protected:
	virtual void OnPrecomputeBegin()override;
	virtual void AddPrecomputedItem(bool isFound, uint prevFrameIndex, uint nextFrameIndex, float percent) override;
protected:
	List<float> mMixes;
	List<bool> mBlendPositives;

	List<float> mPrecomputedMixes;
	List<bool> mPrecomputedBlendPositives;
};

MEDUSA_END;
