#include "StdAfx.h"
#include "OcTreeVisualizer.h"

namespace OcTree {

generic<class T> where T : OcTreeItem
OcTreeVisualizer<T>::OcTreeVisualizer(void)
{
}

generic<class T> where T : OcTreeItem
void OcTreeVisualizer<T>::Visualize(OcTree<T>^ tree, array<Vector3>^% boxes)
{
	BoxBuilderOctreeVisitor visitor;
	tree->octree->visit(visitor);

	vector<float> results = visitor.getResults();
	boxes = gcnew array<Vector3>(results.size() / 3);
	int idx = 0;
	for (int i = 0; i < results.size(); i += 3)
	{
		boxes[idx++] = Vector3(results[i], results[i+1], results[i+2]);
	}
}

/// standard object services ---------------------------------------------------
BoxBuilderOctreeVisitor::BoxBuilderOctreeVisitor()
{ }

BoxBuilderOctreeVisitor::~BoxBuilderOctreeVisitor() { }

/// commands -------------------------------------------------------------------
void BoxBuilderOctreeVisitor::visitRoot(const OctreeCell* pRootCell,
									 const OctreeData& octreeData)
{
	if(pRootCell != 0)
		pRootCell->visit(octreeData, *this);
}

void BoxBuilderOctreeVisitor::visitBranch(const OctreeCell* subCells[8],
									   const OctreeData& octreeData)
{
	/// step through subcells (can be in any order)
	/// subcell numbering:
	///    y z       6 7
	///    |/   2 3  4 5
	///     -x  0 1
	///
	/// (in binary:)
	///    y z           110 111
	///    |/   010 011  100 101
	///     -x  000 001
	///
	for (dword i = 0; i < 8;  ++i)
	{
		const OctreeCell* pSubCell = subCells[i];
		/// avoid null subcells
		if (pSubCell != 0)
		{
			const OctreeData subCellData(octreeData, i);
			// check to see if ray is in sub-cell radius
			const OctreeBound& bounds = subCellData.getBound();
			const Vector3f lower = bounds.getLowerCorner();
			results_m.push_back(lower.x_m);
			results_m.push_back(lower.y_m);
			results_m.push_back(lower.z_m);
			const Vector3f upper = bounds.getUpperCorner();
			results_m.push_back(upper.x_m);
			results_m.push_back(upper.y_m);
			results_m.push_back(upper.z_m);

			/// continue visit traversal
			pSubCell->visit(subCellData, *this);
		}
	}
}

void BoxBuilderOctreeVisitor::visitLeaf(const hxa7241_general::Array<const Block*>& items,
									   const OctreeData& octreeData)
{
	// check items
	for (dword i = 0, end = items.getLength(); i < end; ++i)
	{
		Vector3f pos = items[i]->getPosition();
		results_m.push_back(pos.x_m);
		results_m.push_back(pos.y_m);
		results_m.push_back(pos.z_m);
		
		Vector3f upper = items[i]->getDimensions();
		results_m.push_back(pos.x_m + upper.x_m);
		results_m.push_back(pos.y_m + upper.y_m);
		results_m.push_back(pos.z_m + upper.z_m);
	}
}

vector<float>& BoxBuilderOctreeVisitor::getResults()
{
	return results_m;
}

}