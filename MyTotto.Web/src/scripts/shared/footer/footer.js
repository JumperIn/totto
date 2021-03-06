import { constants } from "../const/const";
import { toggleExistClass, toggleNotExistClass, toggleIcon, toggleExistIcon } from "../const/toggleClass";

function hideFooterItems() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('footer-block__body', 'hidden', i);
	}
}

function showFooterItems() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleExistClass('footer-block__body', 'hidden', i);
	}
}

function hideFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleNotExistClass('footer-block__icon', 'hidden', i)
	}
}

function showFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__body');
	for (var i = 0; i < elems.length; i++) {
		toggleExistClass('footer-block__icon', 'hidden', i);
	}
}

function toggleFooterIcons() {
	var elems = document.getElementsByClassName('footer-block__icon');
	for (var i = 0; i < elems.length; i++) {
		toggleExistIcon('footer-block__icon-toggle', '#icon-angle-bottom', '#icon-angle-top', i);
	}
}

function adaptFooter() {
	if (window.innerWidth < constants.SCREEN_EXTRA_LARGE) {
		hideFooterItems();
		showFooterIcons();
		toggleFooterIcons();
	} else if (window.innerWidth >= constants.SCREEN_EXTRA_LARGE) {
		showFooterItems();
		hideFooterIcons();
		toggleFooterIcons();
	}
}
function dropDownFooterItems() {
	var elems1 = document.getElementsByClassName('footer-accordion');
	var elems2 = document.getElementsByClassName('footer-block__icon-toggle');
	for (var i = 0; i < elems1.length; i++) {
		let elem = elems2[i];
		elems1[i].addEventListener('click', function () {
			if (window.innerWidth < constants.SCREEN_EXTRA_LARGE) {
				this.nextElementSibling.classList.toggle('hidden');
				toggleIcon(elem, '#icon-angle-bottom', '#icon-angle-top');
			}
		})
	}
}

export { adaptFooter, dropDownFooterItems };